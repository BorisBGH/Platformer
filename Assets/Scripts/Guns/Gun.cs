using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gun : MonoBehaviour
{
    [SerializeField] private GameObject _bulletPref;
    [SerializeField] private Transform _spawn;
    [SerializeField] private float _bulletSpeed = 10f;
    [SerializeField] private float _shotPeriod = 0.2f;
    [SerializeField] private GameObject _flash;
    [SerializeField] private AudioSource _shotSound;
    private float _timer;


    void Update()
    {
        _timer += Time.unscaledDeltaTime;

        if (_timer > _shotPeriod && Input.GetMouseButton(0))
        {
            _timer = 0;
            Shot();

        }

    }

    public virtual void Shot()
    {
        GameObject bullet = Instantiate(_bulletPref, _spawn.position, _spawn.rotation);
        bullet.GetComponent<Rigidbody>().velocity = _spawn.forward * _bulletSpeed;
        _shotSound.Play();
        _flash.SetActive(true);
        Invoke(nameof(DisableFlash), 0.2f);
    }

    private void DisableFlash()
    {
        _flash.SetActive(false);
    }

    public virtual void Activate()
    {
        gameObject.SetActive(true);
    }

    public virtual void Deactivate()
    {
        gameObject.SetActive(false);
    }

    public virtual void AddBullets(int bulletsNumber)
    {

    }
}
