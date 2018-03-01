# DICOM (WinForm)

In this project I implemented 3 tasks:

* Histogram transformation (Tab: Lab 3)
* Image filtration (Tab: Lab 4)
* Image segmentation (Tab: Lab 5)

### Histogram transformation ###
What about this part, I used (show picture 2-3):

* [Window\Level](http://www.cs.ioc.ee/~khoros2/one-oper/window-level/front-page.html)
* Inversion image

### Image filtration ###
Here, I used [Kirsch](https://en.wikipedia.org/wiki/Kirsch_operator) operator with 8 compass directions: N, NW, W, SW, S, SE, E, and NE (show picture 4-5).

### Image segmentation ###
And the last part in this project - it's a segmentation. Here, I'm used algorithm ["Region growing"](https://en.wikipedia.org/wiki/Region_growing) (show picture 6-7).

----------------------------------------------------------------------------------

* Original image (Picture 1)
![Снимок.PNG](https://bitbucket.org/repo/Bgk7KzE/images/3491175714-%D0%A1%D0%BD%D0%B8%D0%BC%D0%BE%D0%BA.PNG)

* Window|Level (Picture 2)
![Снимок.PNG](https://bitbucket.org/repo/Bgk7KzE/images/1263846574-%D0%A1%D0%BD%D0%B8%D0%BC%D0%BE%D0%BA.PNG)
You can change value in track's, and the image immediately change.

* Window|Level + Inverse (Picture 3)
![Снимок.PNG](https://bitbucket.org/repo/Bgk7KzE/images/509930008-%D0%A1%D0%BD%D0%B8%D0%BC%D0%BE%D0%BA.PNG)
If you want, you can click checkbox "Inverse".

* Kirsch "NE" + Window|Level (Picture 4)
![Снимок.PNG](https://bitbucket.org/repo/Bgk7KzE/images/421586426-%D0%A1%D0%BD%D0%B8%D0%BC%D0%BE%D0%BA.PNG)
If we use only Kirsch "NE", we can't see the image, so we must add a win|level.

* Kirsch "S" + Normalization (Picture 5)
![Снимок.PNG](https://bitbucket.org/repo/Bgk7KzE/images/2856669088-%D0%A1%D0%BD%D0%B8%D0%BC%D0%BE%D0%BA.PNG)
Also, you can create your gradient filter (Look to right side WinForm -> "Custom").
... or, normalization, as you want.

* Image segmentation "Eye" (Picture 6)
![Снимок.PNG](https://bitbucket.org/repo/Bgk7KzE/images/747118024-%D0%A1%D0%BD%D0%B8%D0%BC%D0%BE%D0%BA.PNG)
In this case, I'm clicked on the left eye, and algorithm choose him. 
If you want to return to origin image, just click right button on the mouse.

* Image segmentation "Brain" (Picture 7)
![Снимок.PNG](https://bitbucket.org/repo/Bgk7KzE/images/572614266-%D0%A1%D0%BD%D0%B8%D0%BC%D0%BE%D0%BA.PNG)
As you can see, I'm clicked a checkbox "Growing the region...". In this case, it's mean, what I must click repeatedly on the region, and with each iteration - region will be growing.
