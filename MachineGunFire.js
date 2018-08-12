
function Update () {
	if(GlobalAmmo.LoadedAmmo>3) {
		if(Input.GetButtonDown("Fire1")) {
			GlobalAmmo.LoadedAmmo -=4;
			var gunsound : AudioSource = GetComponent.<AudioSource>();
			gunsound.Play();
			GetComponent.<Animation>().Play("magunfire");
			}
	}
}