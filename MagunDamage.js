var DamageAmount : int = 5;
var TargetDistance : float;
var AllowedRange : float = 20;

function Update () {
if(GlobalAmmo.LoadedAmmo>3){
	if(Input.GetButtonDown("Fire1")) {

		var Shot : RaycastHit;
			if (Physics.Raycast (transform.position, transform.TransformDirection(Vector3.forward), Shot)) {
				TargetDistance = Shot.distance;
					if (TargetDistance < AllowedRange) {
						Shot.transform.SendMessage("DeductPoint", DamageAmount);
					}
				}
			}
		}
	}