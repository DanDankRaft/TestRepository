for(int i = 0; i < 9; i++)
{
    if(slots[i].getSlotType() == slots[i+9].getSlotType() && slots[i+9].getSlotType() == slots[i+18].getSlotType())
    {
        switch(slots[i].getSlotType())
        {
            case Slot.Type.X:
                gameManager.xScore++; //TODO change gameManager to whatever I called it in the actual script
                Debug.Log("X has been granted a point for a z-horizontal line");
                break;
            case Slot.Type.O:
                gameManager.oScore++;
                Debug.Log("O has been granted a point for a z-horizontal line");
                break;
        }
    }
}



//this is revised code for "slots"
//first, add Slot.Type[] slotsTypes;


void Start()
{
    foreach(Slot slot in slots)
    {
        slotsTypes[value] = slot.getSlotType();
    }
}


//and than, go changing en masse!
