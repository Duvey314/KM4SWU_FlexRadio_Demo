# FlexRadio Demo

This is a simple program that will establish a connection with a 6000 series radio and display the IP Address, Serial Number, Model, Port, and Version. It also has a disconnect button to safely disconnect from the radio.

This was my first time working with C#, Visual Studio, an API, and a FlexRadio so please forgive any errors. I watched tutorials and used example programs to get this up and running. If you have any suggestions please let me know.

## Getting Started

You'll need to first download the [FlexRadio API](https://www.flexradio.com/downloads/).

For this project I used the FlexRadio 6500. It should however work with any of the 6000 series radios.

Before running the program in visual studio you can use the program [Wireshark](https://www.wireshark.org/#download) to examine the UDP messages coming from the radio. This will help you get a feel for the messages the radio is sending and ensure you are connected to the radio.

Be sure to make sure you have a way of getting through any firewalls you have on your computer to connect to the radio.

## Installing

I ran into an issue early on with referencing the flexlib.dll. What I had to do was build each of the sub libraries (vita, util, and flex.uiwpfframework) and then build the flexlib and it worked. However, when testing it after uploading to github I had to reference each library individually.

Once you have the libraries installed you should be able to download the master, reference the libraries, and run the script. When the program is running it should look like this.

![FlexRadio Demo](https://github.com/Duvey314/KM4SWU_FlexRadio_Demo/blob/master/FlexRadio%20Demo%20Screenshot.PNG)

## Next Steps

The big project I would like to use this for is a program that automatcally tunes to the ISS station when it is overhead. Using the 6700 series, a GPS reciever (they have some built into the radio), and ISS location data scraped from the ISS website the radio would automatically change to the transmitting frequency of the ISS and listen in.

## Resources

Here are a few resources that were helpful to me in this project

* [FlexRadio Wiki](wiki.flexradio.com/)
* [FlexRadio Community](community.flexradio.com/)
* [C# Tutorial](https://www.youtube.com/watch?v=gfkTfcpWqAY)

## Acknowledgments

* FlexRadio for letting me use a radio
* The flexradio community for doing most of the heavy lifting
* Gabriel Triggs for helping me learn C# and avoid some beginner mistakes
* James Whiteway (WD5GWY) for his forms example posted on the community forum

