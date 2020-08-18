# StringComparePerformance
This repo was thrown together to test the performance of different logical methods to determine if all letters of the alphabet exist in a given string.

# Example Output
```console
-------- BEGIN COMPARISON TEST --------
Input: the quick brown fox jumps over the lazy dog
Number of Calculations: 1

Test 1
Total Time: 113920
Result: True

Test 2
Total Time: 7759
Result: True

Test 3
Total Time: 51
Result: True

Test 4
Total Time: 46792
Result: True

--------  END COMPARISON TEST  --------

-------- BEGIN COMPARISON TEST --------
Input: the quick brown fox jump over the lazy dog
Number of Calculations: 1

Test 1
Total Time: 42
Result: False

Test 2
Total Time: 95
Result: False

Test 3
Total Time: 38
Result: False

Test 4
Total Time: 200
Result: False

--------  END COMPARISON TEST  --------

-------- BEGIN COMPARISON TEST --------
Input: the quick brown fox jump over the lazy dogthe quick brown fox jump over the lazy dogthe quick brown fox jump over the lazy dogthe quick brown fox jump over the lazy dogthe quick brown fox jump over the lazy dogthe quick brown fox jump over the lazy dogthe quick brown fox jump over the lazy dogthe quick brown fox jump over the lazy dogthe quick brown fox jump over the lazy dogthe quick brown fox jump over the lazy dogthe quick brown fox jump over the lazy dogthe quick brown fox jump over the lazy dogthe quick brown fox jump over the lazy dogthe quick brown fox jump over the lazy dogthe quick brown fox jump over the lazy dogthe quick brown fox jump over the lazy dogthe quick brown fox jump over the lazy dogthe quick brown fox jump over the lazy dogthe quick brown fox jump over the lazy dogthe quick brown fox jump over the lazy dogthe quick brown fox jump over the lazy dogthe quick brown fox jump over the lazy dogthe quick brown fox jump over the lazy dogthe quick brown fox jump over the lazy dog
Number of Calculations: 1

Test 1
Total Time: 182
Result: False

Test 2
Total Time: 158
Result: False

Test 3
Total Time: 115
Result: False

Test 4
Total Time: 404
Result: False

--------  END COMPARISON TEST  --------

-------- BEGIN COMPARISON TEST --------
Input: the quick brown fox jumps over the lazy dogthe quick brown fox jumps over the lazy dogthe quick brown fox jumps over the lazy dogthe quick brown fox jumps over the lazy dogthe quick brown fox jumps over the lazy dogthe quick brown fox jumps over the lazy dogthe quick brown fox jumps over the lazy dogthe quick brown fox jumps over the lazy dogthe quick brown fox jumps over the lazy dogthe quick brown fox jumps over the lazy dogthe quick brown fox jumps over the lazy dogthe quick brown fox jumps over the lazy dogthe quick brown fox jumps over the lazy dogthe quick brown fox jumps over the lazy dogthe quick brown fox jumps over the lazy dogthe quick brown fox jumps over the lazy dogthe quick brown fox jumps over the lazy dogthe quick brown fox jumps over the lazy dogthe quick brown fox jumps over the lazy dogthe quick brown fox jumps over the lazy dogthe quick brown fox jumps over the lazy dogthe quick brown fox jumps over the lazy dogthe quick brown fox jumps over the lazy dogthe quick brown fox jumps over the lazy dog
Number of Calculations: 1

Test 1
Total Time: 212
Result: True

Test 2
Total Time: 132
Result: True

Test 3
Total Time: 51
Result: True

Test 4
Total Time: 526
Result: True

--------  END COMPARISON TEST  --------

-------- BEGIN COMPARISON TEST --------
Input: the quick brown fox jump over the lazy dogthe quick brown fox jump over the lazy dogthe quick brown fox jump over the lazy dogthe quick brown fox jump over the lazy dogthe quick brown fox jump over the lazy dogthe quick brown fox jump over the lazy dogthe quick brown fox jump over the lazy dogthe quick brown fox jump over the lazy dogthe quick brown fox jump over the lazy dogthe quick brown fox jump over the lazy dogthe quick brown fox jump over the lazy dogthe quick brown fox jump over the lazy dogthe quick brown fox jump over the lazy dogthe quick brown fox jump over the lazy dogthe quick brown fox jump over the lazy dogthe quick brown fox jump over the lazy dogthe quick brown fox jump over the lazy dogthe quick brown fox jump over the lazy dogthe quick brown fox jump over the lazy dogthe quick brown fox jump over the lazy dogthe quick brown fox jump over the lazy dogthe quick brown fox jump over the lazy dogthe quick brown fox jump over the lazy dogthe quick brown fox jump over the lazy dogs
Number of Calculations: 1

Test 1
Total Time: 397
Result: True

Test 2
Total Time: 119
Result: True

Test 3
Total Time: 127
Result: True

Test 4
Total Time: 443
Result: True

--------  END COMPARISON TEST  --------

-------- BEGIN COMPARISON TEST --------
Input: the quick brown fox jumps over the lazy dog
Number of Calculations: 100

Test 1
Total Time: 2089
Result: True

Test 2
Total Time: 7049
Result: True

Test 3
Total Time: 4403
Result: True

Test 4
Total Time: 6240
Result: True

--------  END COMPARISON TEST  --------

-------- BEGIN COMPARISON TEST --------
Input: the quick brown fox jump over the lazy dog
Number of Calculations: 100

Test 1
Total Time: 2137
Result: False

Test 2
Total Time: 4415
Result: False

Test 3
Total Time: 3230
Result: False

Test 4
Total Time: 6091
Result: False

--------  END COMPARISON TEST  --------

-------- BEGIN COMPARISON TEST --------
Input: the quick brown fox jump over the lazy dogthe quick brown fox jump over the lazy dogthe quick brown fox jump over the lazy dogthe quick brown fox jump over the lazy dogthe quick brown fox jump over the lazy dogthe quick brown fox jump over the lazy dogthe quick brown fox jump over the lazy dogthe quick brown fox jump over the lazy dogthe quick brown fox jump over the lazy dogthe quick brown fox jump over the lazy dogthe quick brown fox jump over the lazy dogthe quick brown fox jump over the lazy dogthe quick brown fox jump over the lazy dogthe quick brown fox jump over the lazy dogthe quick brown fox jump over the lazy dogthe quick brown fox jump over the lazy dogthe quick brown fox jump over the lazy dogthe quick brown fox jump over the lazy dogthe quick brown fox jump over the lazy dogthe quick brown fox jump over the lazy dogthe quick brown fox jump over the lazy dogthe quick brown fox jump over the lazy dogthe quick brown fox jump over the lazy dogthe quick brown fox jump over the lazy dog
Number of Calculations: 100

Test 1
Total Time: 16134
Result: False

Test 2
Total Time: 10672
Result: False

Test 3
Total Time: 11278
Result: False

Test 4
Total Time: 34851
Result: False

--------  END COMPARISON TEST  --------

-------- BEGIN COMPARISON TEST --------
Input: the quick brown fox jumps over the lazy dogthe quick brown fox jumps over the lazy dogthe quick brown fox jumps over the lazy dogthe quick brown fox jumps over the lazy dogthe quick brown fox jumps over the lazy dogthe quick brown fox jumps over the lazy dogthe quick brown fox jumps over the lazy dogthe quick brown fox jumps over the lazy dogthe quick brown fox jumps over the lazy dogthe quick brown fox jumps over the lazy dogthe quick brown fox jumps over the lazy dogthe quick brown fox jumps over the lazy dogthe quick brown fox jumps over the lazy dogthe quick brown fox jumps over the lazy dogthe quick brown fox jumps over the lazy dogthe quick brown fox jumps over the lazy dogthe quick brown fox jumps over the lazy dogthe quick brown fox jumps over the lazy dogthe quick brown fox jumps over the lazy dogthe quick brown fox jumps over the lazy dogthe quick brown fox jumps over the lazy dogthe quick brown fox jumps over the lazy dogthe quick brown fox jumps over the lazy dogthe quick brown fox jumps over the lazy dog
Number of Calculations: 100

Test 1
Total Time: 16418
Result: True

Test 2
Total Time: 5818
Result: True

Test 3
Total Time: 4305
Result: True

Test 4
Total Time: 33991
Result: True

--------  END COMPARISON TEST  --------

-------- BEGIN COMPARISON TEST --------
Input: the quick brown fox jump over the lazy dogthe quick brown fox jump over the lazy dogthe quick brown fox jump over the lazy dogthe quick brown fox jump over the lazy dogthe quick brown fox jump over the lazy dogthe quick brown fox jump over the lazy dogthe quick brown fox jump over the lazy dogthe quick brown fox jump over the lazy dogthe quick brown fox jump over the lazy dogthe quick brown fox jump over the lazy dogthe quick brown fox jump over the lazy dogthe quick brown fox jump over the lazy dogthe quick brown fox jump over the lazy dogthe quick brown fox jump over the lazy dogthe quick brown fox jump over the lazy dogthe quick brown fox jump over the lazy dogthe quick brown fox jump over the lazy dogthe quick brown fox jump over the lazy dogthe quick brown fox jump over the lazy dogthe quick brown fox jump over the lazy dogthe quick brown fox jump over the lazy dogthe quick brown fox jump over the lazy dogthe quick brown fox jump over the lazy dogthe quick brown fox jump over the lazy dogs
Number of Calculations: 100

Test 1
Total Time: 16114
Result: True

Test 2
Total Time: 12237
Result: True

Test 3
Total Time: 12523
Result: True

Test 4
Total Time: 40863
Result: True

--------  END COMPARISON TEST  --------

-------- BEGIN COMPARISON TEST --------
Input: the quick brown fox jumps over the lazy dog
Number of Calculations: 10000

Test 1
Total Time: 157300
Result: True

Test 2
Total Time: 475305
Result: True

Test 3
Total Time: 453828
Result: True

Test 4
Total Time: 404885
Result: True

--------  END COMPARISON TEST  --------

-------- BEGIN COMPARISON TEST --------
Input: the quick brown fox jump over the lazy dog
Number of Calculations: 10000

Test 1
Total Time: 148784
Result: False

Test 2
Total Time: 451948
Result: False

Test 3
Total Time: 336895
Result: False

Test 4
Total Time: 384148
Result: False

--------  END COMPARISON TEST  --------

-------- BEGIN COMPARISON TEST --------
Input: the quick brown fox jump over the lazy dogthe quick brown fox jump over the lazy dogthe quick brown fox jump over the lazy dogthe quick brown fox jump over the lazy dogthe quick brown fox jump over the lazy dogthe quick brown fox jump over the lazy dogthe quick brown fox jump over the lazy dogthe quick brown fox jump over the lazy dogthe quick brown fox jump over the lazy dogthe quick brown fox jump over the lazy dogthe quick brown fox jump over the lazy dogthe quick brown fox jump over the lazy dogthe quick brown fox jump over the lazy dogthe quick brown fox jump over the lazy dogthe quick brown fox jump over the lazy dogthe quick brown fox jump over the lazy dogthe quick brown fox jump over the lazy dogthe quick brown fox jump over the lazy dogthe quick brown fox jump over the lazy dogthe quick brown fox jump over the lazy dogthe quick brown fox jump over the lazy dogthe quick brown fox jump over the lazy dogthe quick brown fox jump over the lazy dogthe quick brown fox jump over the lazy dog
Number of Calculations: 10000

Test 1
Total Time: 1566745
Result: False

Test 2
Total Time: 962525
Result: False

Test 3
Total Time: 1153918
Result: False

Test 4
Total Time: 2975605
Result: False

--------  END COMPARISON TEST  --------

-------- BEGIN COMPARISON TEST --------
Input: the quick brown fox jumps over the lazy dogthe quick brown fox jumps over the lazy dogthe quick brown fox jumps over the lazy dogthe quick brown fox jumps over the lazy dogthe quick brown fox jumps over the lazy dogthe quick brown fox jumps over the lazy dogthe quick brown fox jumps over the lazy dogthe quick brown fox jumps over the lazy dogthe quick brown fox jumps over the lazy dogthe quick brown fox jumps over the lazy dogthe quick brown fox jumps over the lazy dogthe quick brown fox jumps over the lazy dogthe quick brown fox jumps over the lazy dogthe quick brown fox jumps over the lazy dogthe quick brown fox jumps over the lazy dogthe quick brown fox jumps over the lazy dogthe quick brown fox jumps over the lazy dogthe quick brown fox jumps over the lazy dogthe quick brown fox jumps over the lazy dogthe quick brown fox jumps over the lazy dogthe quick brown fox jumps over the lazy dogthe quick brown fox jumps over the lazy dogthe quick brown fox jumps over the lazy dogthe quick brown fox jumps over the lazy dog
Number of Calculations: 10000

Test 1
Total Time: 1708399
Result: True

Test 2
Total Time: 484985
Result: True

Test 3
Total Time: 569455
Result: True

Test 4
Total Time: 3073860
Result: True

--------  END COMPARISON TEST  --------

-------- BEGIN COMPARISON TEST --------
Input: the quick brown fox jump over the lazy dogthe quick brown fox jump over the lazy dogthe quick brown fox jump over the lazy dogthe quick brown fox jump over the lazy dogthe quick brown fox jump over the lazy dogthe quick brown fox jump over the lazy dogthe quick brown fox jump over the lazy dogthe quick brown fox jump over the lazy dogthe quick brown fox jump over the lazy dogthe quick brown fox jump over the lazy dogthe quick brown fox jump over the lazy dogthe quick brown fox jump over the lazy dogthe quick brown fox jump over the lazy dogthe quick brown fox jump over the lazy dogthe quick brown fox jump over the lazy dogthe quick brown fox jump over the lazy dogthe quick brown fox jump over the lazy dogthe quick brown fox jump over the lazy dogthe quick brown fox jump over the lazy dogthe quick brown fox jump over the lazy dogthe quick brown fox jump over the lazy dogthe quick brown fox jump over the lazy dogthe quick brown fox jump over the lazy dogthe quick brown fox jump over the lazy dogs
Number of Calculations: 10000

Test 1
Total Time: 1556039
Result: True

Test 2
Total Time: 1097630
Result: True

Test 3
Total Time: 1284502
Result: True

Test 4
Total Time: 2785786
Result: True

--------  END COMPARISON TEST  --------
```