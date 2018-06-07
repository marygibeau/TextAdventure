using UnityEngine;
using System.Collections;
using UnityEngine.UI;
public class TextController : MonoBehaviour {
public Text text;
private enum States {cell, mirror, sheets_0, lock_0, cell_mirror, sheets_1, lock_1,
freedom,
corridor_0, stairs_0, floor, closet_door, stairs_1, corridor_1, in_closet, stairs_2,
corridor_2, corridor_3, courtyard};
private States myState;
// Use this for initialization
void Start () {
myState = States.cell;
}
// Update is called once per frame
void Update () {
if(myState == States.cell){cell ();}
else if(myState == States.sheets_0){sheets_0();}
else if(myState == States.lock_0){lock_0();}
else if(myState == States.mirror){mirror();}
else if(myState == States.cell_mirror){cell_mirror();}
else if(myState == States.sheets_1){sheets_1();}
else if(myState == States.lock_1){lock_1();}
else if(myState == States.freedom){freedom();}
else if(myState == States.corridor_0) {corridor_0();}
else if(myState == States.stairs_0){stairs_0();}
else if(myState == States.floor){floor();}
else if(myState == States.closet_door){closet_door();}
else if(myState == States.corridor_1){corridor_1();}
else if(myState == States.corridor_2){corridor_2();}
else if(myState == States.stairs_1){stairs_1();}
else if(myState == States.in_closet){in_closet();}
else if(myState == States.stairs_2){stairs_2();}
else if(myState == States.corridor_3){corridor_3();}
else if(myState == States.courtyard){courtyard();}
if (Input.GetKeyDown("escape")) {Application.Quit();}
}
#region State handler methods
void cell(){
text.text = "Your cell is small and dank. It reeks of the past prisoners "+
"and you wonder ab
"you hardly recognize. You wipe the soot off your face and
try to fix"+
" your hair but you’re still unsatisfied with the face that
stares back"+
" at you. You punch the mirror out of frustration. The mirror
shatters "+
"and the shards fall to the floor. You stare down at the
broken pieces"+
" beneath you.\n\n"+
"Press T to Take a shard or R to Return to Cell";
if(Input.GetKeyDown(KeyCode.R)){myState = States.cell;}
else if(Input.GetKeyDown(KeyCode.T)){myState = States.cell_mirror;}
}
void cell_mirror(){
text.text = "You pick up a piece of the mirror and sheath it in"+
" your waistband \n\n"+
"Press S to view Sheets or L to view Lock";
if(Input.GetKeyDown(KeyCode.S)){myState = States.sheets_1;}
else if(Input.GetKeyDown(KeyCode.L)){myState = States.lock_1;}
}
void sheets_1(){
text.text = "You gather the sheets and shake them out. "+
"You look about for some way to use them but "+
"you realize they are of little help. You crumple"+
" the sheets and throw them on the hard concrete floor."+
" Maybe you should take another look around.\n\n"+
"Press R to Return to Cell";
if(Input.GetKeyDown(KeyCode.R)){myState = States.cell_mirror;}
}
void lock_1(){
text.text = "You glance at the lock on the door and its long shadow"+
" splayed across the jail floor by the sunlight streaming"+
" in from the small window. You hear footsteps approaching.\n\n"+
"Press R to Return to Cell or O to open ";
if(Input.GetKeyDown(KeyCode.R)){myState = States.cell_mirror;}
else if(Input.GetKeyDown(KeyCode.O)){myState = States.freedom;}
}
void freedom(){
text.text = "You quickly lie face down on the cold concrete floor. "+
"A voice calls at you. You don’t respond. You hear keys "+
"jangle and the metal door creak open as someone
unlocks "+
"the door. The boots stop beside you head as someone
squats"+
" down and pokes you. You quickly take the mirror shard
out"+
" of your pocket and slice at the jailer. The mirror finds "+
"it’s home in their jugular and you bolt out of the cell into"+
" the corridor.\n\n"+
"Press C to Continue";
if(Input.GetKeyDown(KeyCode.C)){myState = States.corridor_0;}
}
void corridor_0(){
text.text = "Your heart is beating fast from the adrenaline as you take"+
" in your surroundings. The jailer’s bag lies at your feet, "+
"to your left there is some sort of closet door, and at the "+
"end of the hall to yo
text.text = "To your left there is some sort of closet door, and at "+
"the end of the hall to your right you see some stairs.\n\n"+
"Press S to go up the Stairs or P to Pick the lock to the closet";
if(Input.GetKeyDown(KeyCode.S)){myState = States.stairs_1;}
else if(Input.GetKeyDown(KeyCode.P)){myState = States.in_closet;}
}
void stairs_1(){
text.text = "You dash up the stairs and peak about. There seems to "+
"be a lavish party going on and several body guards
stand"+
" at the outskirts of the room. Maybe this isn’t such a "+
"good idea.\n\n Press R to Return";
if(Input.GetKeyDown(KeyCode.R)){myState = States.corridor_1;}
}
void in_closet(){
text.text = "You walk up to the closet door but it seems to be locked."+
" You remember the hair clip in your waistband and pick
the"+
" lock. Inside you find some cleaning supplies as well as
a"+
" janitor’s uniform.\n\n Press R to Return or D to Dress in
the uniform";
if(Input.GetKeyDown(KeyCode.R)){myState = States.corridor_2;}
else if(Input.GetKeyDown(KeyCode.D)){myState = States.corridor_3;}
}
void corridor_2(){
text.text = "You walk back into the corridor leaving the closet door ajar."+
" Your only other option is to go upstairs.\n\n"+
"Press S to go up the Stairs or B to go Back to the closet";
if(Input.GetKeyDown(KeyCode.S)){myState = States.stairs_2;}
else if(Input.GetKeyDown(KeyCode.B)){myState = States.in_closet;}
}
void stairs_2(){
text.text = "You dash up the stairs and peak about. There seems to "+
"be a lavish party going on and several body guards
stand"+
" at the outskirts of the room. Maybe this isn’t such a "+
"good idea.\n\n Press R to Return";
if(Input.GetKeyDown(KeyCode.R)){myState = States.corridor_2;}
}
void corridor_3(){
text.text = "You put on the janitor’s uniform. It’s a little baggy"+
" but it’ll do. You walk back into the corridor.\n\n"+
"Press S to go up the Stairs or U to Undress";
if(Input.GetKeyDown(KeyCode.S)){myState = States.courtyard;}
else if(Input.GetKeyDown(KeyCode.U)){myState = States.in_closet;}
}
void courtyard(){
text.text = "You calmly walk up the stairs. You pull your hat down"+
" and walk as though you belong there in the hopes that"+
" no one recognizes you. You walk past the body guards"+
" and party goers undetected and out into the courtyard."+
" The sun beats down on your face and you breathe in
the"+
" fresh air. You dash across the courtyard and hop the"+
" low bearing wall to freedom.\n\n"+
"Press P to Play again or the escape key to quit";
if(Input.GetKeyDown(KeyCode.P)){myState = States.cell;}
}
#endregion
}