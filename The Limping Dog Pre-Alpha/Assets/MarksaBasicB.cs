﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MarksaBasicB : MonoBehaviour
{
    float charSpeed = 2;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.forward * Input.GetAxis("Vertical") * charSpeed); //Moves Character Forward and Back
        transform.Translate(Vector3.right * Input.GetAxis("Horizontal") * charSpeed);
        transform.Rotate(Vector3.up * Input.GetAxis("Mouse X"));
    }
}
/*
 This is something new
The Casper Slide part two
Featuring the Platinum Band
And this time
We're going to get funky
Funky

Everybody clap your hands
Clap, clap, clap, clap your hands
Clap, clap, clap, clap your hands
Alright now, we're going to do the basic step

To the left
Take it back now, y'all
One hop this time
Right foot, let's stomp
Left foot, let's stomp
Cha cha real smooth

Turn it out
To the left
Take it back now y'all
One hop this time
Right foot, let's stomp
Left foot, let's stomp
Cha cha now y'all
Now it's time to get funky

To the right now
To the left
Take it back now y'all
One hop this time
One hop this time
Right foot two stomps
Left foot two stomps
Slide to the left
Slide to the right
Criss cross
Criss cross
Cha cha real smooth

Let's go to work
To the left
Take it back now y'all
Two hops this time
Two hops this time
Right foot two stomps
Left foot two stomps
Hands on you knees, hands on your knees
Get funky with it
Oh yeah
Come on, cha cha now y'all

Turn it out
To the left
Take it back now y'all
Five hops this time
Right foot let's stomp
Left foot let's stomp
Right foot again
Left foot again
Right foot let's stomp
Left foot let's stomp
Freeze
Everybody clap your hands

Come on y'all, check it out y'all
How low can you go?
Can you go down low?
All the way to the floor?
How low can you go?
Can you bring it to the top?
Like it never never stop?
Can you bring it to the top?
One hop
Right foot now
Left foot now y'all
Cha cha real smooth

Turn it out
To the left
Take it back now y'all
One hop this time
One hop this time
Reverse
Reverse
Slide to the left
Slide to the right
Reverse, reverse
Reverse, reverse
Cha cha now y'all
Cha cha again
Cha cha now y'all
Cha cha again

Turn it out
To the left
Take it back now y'all
Two hops, two hops
Two hops, two hops
Right foot let's stomp
Left foot let's stomp
Charlie brown
Hop it out now
Slide to the right
Slide to the left
Take it back now y'all
Cha cha now y'all

Turn it out
To the left
Take it back now y'all
Three hops this time
Right foot now
Left foot now y'all
Cha cha now

Turn it out
Be lookin' out for part three
It's gonna be comin' to you soon
But right now we gonna keep this groove
Here we go, to the right, to the right y'all
To the left
Take it back now y'all
Four hops this time
Right foot now
Left foot now
Cha cha now y'all
Cha cha again
Cha cha again
Turn it out
Take it back now, y'all
Right foot let's stomp
Left foot let's stomp
Six hops this time
Right foot let's stomp
Left foot let's stomp
Right foot two stomps
Left foot two stomps
Criss cross
Slide to the left
Slide to the right
Let me hear you clap your hands

Cha cha now
Cha cha again
Turn it out
To the left
Take it back now y'all
Two hops, two hops
Two hops, two hops
Right foot two stomps
Left foot two stomps
Hands on your knees, hands on your knees
Ah, yeah
Get funky with it, get down now y'all
Come on, come on, cha cha now y'all

Let's go to work
As I told you before
This is the Casper Slide part two
I am the originator of this slide
If anybody tell you any different
They're telling you dead wrong
So in the meantime, in between time
I'm outta here
Platinum, take 'em home
Ah yeah, mm hmm 
Yeah, yeah, do that stuff, do it
Ah yeah, I'm outta here y'all
Peace (peace)
     
     */
