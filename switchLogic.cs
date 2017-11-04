//plan for switches:
//on collision enter, change switch is activated to true, send starting event
//oncollison exit, chance switch is activated to false, send ending event

event potato;
delegate whatIsLove;
bool isPressed;
void Update()
{
    
}

void onCollisionEnter(Colliison col)
{
    isPressed = true;
    //run that event thing
}

void onCollisionExit()
{
    isPressed = false;
}