void onDeath()
{
    GetComponent<PlayerMovement>().isActiveandEnabled = false;
    GetComponent<PlayerRotation>().isActiveandEnabled = false;
    GetComponent<Animator>().Play(deathanimation);
}

//remember to play this when deathanimation ends
public void onDeathAnimationEnd()
{
    isDead = true;
    //TODO: display text to restart
}
Vector3 starterPosition;
Vector3 starterRotation;
void Start()
{
    starterPosition = transform.position;
    starterRotation = transform.eulerAngles;
}

void Update()
{
    if(isDead = true && Input.GetButtonDown("Jump"))
    {
        //bring back to life!
        isDead = false;
        GetComponent<PlayerMovement>().isActiveandEnabled = true;
        GetComponent<PlayerRotation>().isActiveandEnabled = true;
        transform.position = starterPosition;
        transform.eulerAngles = starterRotation;
        //TODO: hide text to restart
    }
}