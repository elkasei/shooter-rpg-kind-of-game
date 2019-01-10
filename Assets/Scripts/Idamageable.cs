using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface Idamageable
{
	void TakeDamage (int damage);
}

public interface IUsable
{
	void Use();
}
