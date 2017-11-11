//plan for switches:
//on collision enter, change switch is activated to true, send starting event
//oncollison exit, chance switch is activated to false, send ending event
//TODO: add collider to the bottom of the player for use with switches

event switchTurnOn;
event switchTurnOff;
int amountOfCollisions++;
bool isColliding;
void FixedUpdate()
{
    if(amountOfCollisions > 0)
        isColliding = true;
    else
        isColliding = false;
}

void onCollisionEnter(Colliison col)
{
    amountOfCollisions++;
    if(amountOfCollisions == 1)
    {
        switchTurnOn();
    }
}

void onCollisionExit()
{
    amountOfCollisions--;
    if(amountOfCollisions == 0)
    {
        switchTurnOff();
    }
}