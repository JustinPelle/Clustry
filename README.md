
# Clustry

## Description
This code is a simple model implementing k-means clustering in 2D in C#. I had written it as I was trying out approaches to a posed problem of a course assignment during my bachelor. We ended up not using this clustering approach, but I thought it was clean and working quite well. Also we did still get a passing grade on the course assignment :).

![](https://github.com/JustinPelle/Clustry/blob/main/clus_vis.jpg)
*Visual demonstration of the clustering output*

## Dependencies
This code has no dependencies, except that it uses python’s matplotlib to visualize the clustering.

## Execution
To test out the model, execute the .bat file ‘run.bat’. The model will run on some demo data and visualize the clustering through creating ‘clus_vis.png’.

## Notes
- Due to stochastic sampling of centroids, results are not consistent. To negate this; determine the centroids you want to use beforehand, of run the model multiple times across different stochastic initialization of centroids and pick out the best (most applicable) clustering.
