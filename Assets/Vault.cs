using System.Collections;
using System.Collections.Generic;
using System.Net.HTTP;
using UnityEngine;

public class Vault : MonoBehaviour
{
	private static HttpClient client = new HttpClient();

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

	void Login(string username, string password)
	{
		Dictionary<string, string> parameters = new Dictionary<string, string>();
		parameters.Add("display", "popup");
		parameters.Add("scope", "openid profile email");
		parameters.Add("client_id", "keyforge-web-portal");
		parameters.Add("state", "/");
		parameters.Add("redirect_uri", "https://www.keyforgegame.com/authorize");
		parameters.Add("nonce", "4HM~Z5f8");

		FormUrlEncodedContent urlParameters = new FormUrlEncodedContent(parameters);

		Dictionary<string, string> loginParameters = Dictionary<string, string>();
		loginParameters.Add("login", username);
		loginParameters.Add("password", password);

		FormUrlEncodedContent loginParameters = new FormUrlEncodedContent(loginParameters);

		string path = string.Format("https://account.asmodee.net/en/signin?{0}", urlParameters);
		HttpResponseMessage response = await client.PostAsync(path, loginParameters);
	}

}

public class VaultUser
{
	private string id;
	private string userName;
	private string email;
	private string avatar;
	private string location;
	private string qrCode;
	private string accountURL;
	private string language;
	private int amberShards;
	private int amberShardsCollected;
	private int keys;
	private string token;

	public string ID
	{
		get { return id; }
		set { id = value; }
	}

	public string UserName
	{
		get { return userName; }
		set { userName = value; }
	}

	public string Email
	{
		get { return email; }
		set { email = value; }
	}

	public string Avatar
	{
		get { return avatar; }
		set { avatar = value; }
	}

	public string Location
	{
		get { return location }
		set { location = value; }
	}

	public string QRCode
	{
		get { return qrCode; }
		set { qrCode = value; }
	}

	public string GetAccountURL
	{
		get { return accountURL; }
		set { accountURL = value; }
	}

	public string Language
	{
		get { return language; }
		set { language = value; }
	}

	public int AmberShards
	{
		get { return amberShards; }
		set { amberShards = value; }
	}

	public int AmberShardsCollected
	{
		get { return amberShardsCollected; }
		set { amberShardsCollected = value; }
	}

	public int Keys
	{
		get { return keys; }
		set { keys = value; }
	}

	public string Token
	{
		get { return token; }
		set { token = value; }
	}
}