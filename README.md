# Canny

The desktop application developed in C# and C++. It represents the Canny edge detection algorithm and it follows the next steps:
- Smoothing the image with a Gaussian filter to reduce noise and unwanted details and textures
- Computing gradient of the image
- Finding local maximums, thinning edges
- Setting upper and lower thresholds, suppressing values above and below thresholds
- Linking edge segments

## Application

For implementing algorithm code, C# and C++ were used. Application is implemented in that way that shows each step in this process, one after another.

![alt tag](https://imgur.com/5CqMaEV.png)

### Steps

On the picture shown below, each step in this algorithm is shown:

![alt tag](https://imgur.com/yRKKffX.png)

### Parameters

Users can enter parameters used in algorithm calculations. A low and high threshold can be changed, as well as Gauss mask and Sigma. For different parameters, different results are obtained. As an example, let's change one parameter, for example, a high threshold. The results are shown for a high threshold of equal 20 and 200.

![alt tag](https://imgur.com/4iiAif2.png)

License
----

© 2019 Dragana Vučić, Faculty of Electronic Engineering, University of Niš
