using UnityEngine;
using System.Collections;
using SIGVerse.Competition.CrestCamp;


public class GraphScript : MonoBehaviour, IRosMsgReceiveHandler
{
	public float xmin = -3f;
	public float xmax = 3f;
	public float zmin = -3f;
	public float zmax = 3f;
	public int xmesh = 150;
	public int zmesh = 150;
	public int resolution = 150;
	public float yscale = 10f;
	private Color pointColor = new Color(1f, 1f, 1f);
	public float pointSize = 0.05f;

	public GameObject distributionPrefab;

	private NormalDistribution dist;
	private ParticleSystem.Particle[] points;
	private bool changed;

	GameObject distributaion;

	void Start()
	{

	}
	
	void Update()
	{
		if (changed) {
			CalculateProbabilities();
		}
	}

	public void GraphChanged()
	{
		changed = true;
	}

	private int CalculateNumberOfPoints()
	{
		return (xmesh + 1) * (resolution + 1) + (zmesh + 1) * (resolution + 1);
	}

	private void BuildMesh()
	{
		int i = 0;
		for (int xi = 0; xi <= xmesh; ++xi) {
			for (int zi = 0; zi <= resolution; ++zi) {
				float x = xmin + (xmax - xmin) * xi / xmesh;
				float z = zmin + (zmax - zmin) * zi / resolution;
				SetPoint(ref points[i++], x, z);
			}
		}
		for (int zi = 0; zi <= zmesh; ++zi) {
			for (int xi = 0; xi <= resolution; ++xi) {
				float x = xmin + (xmax - xmin) * xi / resolution;
				float z = zmin + (zmax - zmin) * zi / zmesh;
				SetPoint(ref points[i++], x, z);
			}
		}

		CalculateProbabilities();
	}

	private void SetPoint(ref ParticleSystem.Particle p, float x, float z)
	{
		p.position = new Vector3(x, 0f, z);
		p.startColor = pointColor;
		p.startSize = pointSize;
	}

	private void CalculateProbabilities()
	{
		for (int i = 0; i < points.Length; ++i) {
			float x = points[i].position.x;
			float z = points[i].position.z;
			float y = dist.Probability(x, z);
			points[i].position = new Vector3(x, y * yscale, z);
		}

		UpdatePoints();
	}

	private void UpdatePoints()
	{
		ParticleSystem particleSystem = this.distributaion.GetComponent<ParticleSystem> ();
		particleSystem.SetParticles(points, points.Length);
		changed = false;
	}

	public void OnReceiveRosMessage(SIGVerse.ROSBridge.CrestCamp.PlaceConceptMsg placeConceptMsg)
	{   

		pointColor =new Color(Random.value, Random.value, Random.value, 1.0f);

		//インスタンス化
		this.distributaion = GameObject.Instantiate (this.distributionPrefab);
		//トピックで取った位置をセット
		this.distributaion.transform.position = new Vector3( -(float)placeConceptMsg.y, -0.15f, (float)placeConceptMsg.x);
		//dist:正規分布
		dist = new NormalDistribution();
		dist.x1Var = (float)placeConceptMsg.vx;
		dist.x2Var = (float)placeConceptMsg.vy;
		points = new ParticleSystem.Particle[CalculateNumberOfPoints()];
		BuildMesh();

		Debug.Log("Received concept message : "+
			placeConceptMsg.x +", "+
			placeConceptMsg.y +", "+ 
			placeConceptMsg.vx +", "+ 
			placeConceptMsg.vy);
	}
}
public class NormalDistribution
{
	public float x1Mean  = 0f;
	public float x2Mean  = 0f;
	public float x1Var   = 1f;
	public float x2Var   = 1f;
	public float x1X2Cov = 0f;

	public float Probability(float x1, float x2)
	{
		float dx1 = x1 - x1Mean;
		float dx2 = x2 - x2Mean;
		float det = x1Var * x2Var - x1X2Cov * x1X2Cov;
		float coef = 1f / (2f * Mathf.PI * Mathf.Sqrt(det));
		float dist = (dx1 * dx1 * x2Var - 2f * dx1 * dx2 * x1X2Cov + dx2 * dx2 * x1Var) / det;
		float probability = coef * Mathf.Exp(-dist / 2f);

		return probability;
	}
}
