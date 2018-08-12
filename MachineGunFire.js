//Simple GunFire Code using js;
//You need to create Ammo js program 1st that Stores the total Ammo
function Update () {
	if(Ammo.LoadedAmmo>0) {
		if(Input.GetButtonDown("Fire1")) {
			Ammo.LoadedAmmo -=4;
			var gunsound : AudioSource = GetComponent.<AudioSource>();
			gunsound.Play();
			GetComponent.<Animation>().Play("magunfire");
			}
	}
}
