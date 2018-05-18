# Canny

Desktop application developed in C# and C++. It represents Canny edge detection algorithm and it follows next steps:

  - Smoothing the image with a Gaussian filter to reduce noise and unwanted details and textures
  - Computing gradient of the image
  - Finding local maximums, thinning edges
  - Setting upper and lower tresholds, suppressing values above and below thresholds
  - Linking edge segments

The [full-text report][report] can be found on ResearchGate.

## Application

For implementing algorithm code, C# and C++ were used. Application is implemented on that way that it shows each step in this process, one after another.

![alt tag](https://imgur.com/5CqMaEV.png)

### Steps

On the picture shown below, each step in this algorithm is shown:

![alt tag](https://imgur.com/yRKKffX.png)

### Parameters

User can enter parameters used in algorithm calculations. Low and high treshold can be changed, as well as Gauss mask and Sigma. For different parameters, different results are obtained. As example, lets change one parameter, for example high threshold. The results are shown for high treshold equal 20 and 200.

![alt tag](https://imgur.com/4iiAif2.png)

License
----

Dragana Vučić, Faculty of Electronic Engineering, University of Niš

**Contact or feedback on: dragana.vucic@live.com**

[report]: <https://www.researchgate.net/publication/325226030_Otkrivanje_ivica_na_slici_primenom_Canny-jeve_metode>
