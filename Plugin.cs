using BepInEx;
using BepInEx.Configuration;
using UnityEngine;

namespace DisableHelmetVisor
{
	[BepInPlugin("DeathWrench.DisableHelmetVisor", "Disable Helmet Visor", "0.0.1")]
	public class DisableHelmetVisor : BaseUnityPlugin
	{
		public void Awake()
		{
			this.Config_DisableHelmet = base.Config.Bind<bool>("General", "Disable Helmet UI", true, "Remove visor overlay");
		}
		public void Update()
		{
			GameObject gameObject = GameObject.Find("Systems");
			gameObject?.transform.Find("Rendering").Find("PlayerHUDHelmetModel").gameObject.SetActive(!this.Config_DisableHelmet.Value);
		}
		private ConfigEntry<bool> Config_DisableHelmet;
	}
}
