﻿An algorithm that takes a matrix of integers, looks for a subject value, and makes the entire row/column of the subjects cell the same value.

E.g... given the following matrix:

1, 2, 3, 4<br>
1, 0, 3, 4<br>
1, 2, 0, 4<br>
1, 2, 3, 4

The following will be returned:

1, 0, 0, 4<br>
0, 0, 0, 0<br>
0, 0, 0, 0<br>
1, 0, 0, 4