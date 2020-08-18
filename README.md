# StringComparePerformance
This repo was thrown together to test the performance of different logical methods to determine if all letters of the alphabet exist in a given string.

# Example Output
```console
-------- BEGIN COMPARISON TEST --------
Input: the quick brown fox jumps over the lazy dog
Number of Calculations: 1

Test 1
Total Time: 105066
Result: True

Test 2
Total Time: 7583
Result: True

Test 3
Total Time: 50
Result: True

--------  END COMPARISON TEST  --------

-------- BEGIN COMPARISON TEST --------
Input: the quick brown fox jump over the lazy dog
Number of Calculations: 1

Test 1
Total Time: 93
Result: False

Test 2
Total Time: 41
Result: False

Test 3
Total Time: 64
Result: False

--------  END COMPARISON TEST  --------

-------- BEGIN COMPARISON TEST --------
Input: the quick brown fox jump over the lazy dogthe quick brown fox jump over the lazy dogthe quick brown fox jump over the lazy dogthe quick brown fox jump over the lazy dogthe quick brown fox jump over the lazy dogthe quick brown fox jump over the lazy dogthe quick brown fox jump over the lazy dogthe quick brown fox jump over the lazy dogthe quick brown fox jump over the lazy dogthe quick brown fox jump over the lazy dogthe quick brown fox jump over the lazy dogthe quick brown fox jump over the lazy dogthe quick brown fox jump over the lazy dogthe quick brown fox jump over the lazy dogthe quick brown fox jump over the lazy dogthe quick brown fox jump over the lazy dogthe quick brown fox jump over the lazy dogthe quick brown fox jump over the lazy dogthe quick brown fox jump over the lazy dogthe quick brown fox jump over the lazy dogthe quick brown fox jump over the lazy dogthe quick brown fox jump over the lazy dogthe quick brown fox jump over the lazy dogthe quick brown fox jump over the lazy dog
Number of Calculations: 1

Test 1
Total Time: 177
Result: False

Test 2
Total Time: 108
Result: False

Test 3
Total Time: 114
Result: False

--------  END COMPARISON TEST  --------

-------- BEGIN COMPARISON TEST --------
Input: the quick brown fox jumps over the lazy dogthe quick brown fox jumps over the lazy dogthe quick brown fox jumps over the lazy dogthe quick brown fox jumps over the lazy dogthe quick brown fox jumps over the lazy dogthe quick brown fox jumps over the lazy dogthe quick brown fox jumps over the lazy dogthe quick brown fox jumps over the lazy dogthe quick brown fox jumps over the lazy dogthe quick brown fox jumps over the lazy dogthe quick brown fox jumps over the lazy dogthe quick brown fox jumps over the lazy dogthe quick brown fox jumps over the lazy dogthe quick brown fox jumps over the lazy dogthe quick brown fox jumps over the lazy dogthe quick brown fox jumps over the lazy dogthe quick brown fox jumps over the lazy dogthe quick brown fox jumps over the lazy dogthe quick brown fox jumps over the lazy dogthe quick brown fox jumps over the lazy dogthe quick brown fox jumps over the lazy dogthe quick brown fox jumps over the lazy dogthe quick brown fox jumps over the lazy dogthe quick brown fox jumps over the lazy dog
Number of Calculations: 1

Test 1
Total Time: 191
Result: True

Test 2
Total Time: 108
Result: True

Test 3
Total Time: 49
Result: True

--------  END COMPARISON TEST  --------

-------- BEGIN COMPARISON TEST --------
Input: the quick brown fox jump over the lazy dogthe quick brown fox jump over the lazy dogthe quick brown fox jump over the lazy dogthe quick brown fox jump over the lazy dogthe quick brown fox jump over the lazy dogthe quick brown fox jump over the lazy dogthe quick brown fox jump over the lazy dogthe quick brown fox jump over the lazy dogthe quick brown fox jump over the lazy dogthe quick brown fox jump over the lazy dogthe quick brown fox jump over the lazy dogthe quick brown fox jump over the lazy dogthe quick brown fox jump over the lazy dogthe quick brown fox jump over the lazy dogthe quick brown fox jump over the lazy dogthe quick brown fox jump over the lazy dogthe quick brown fox jump over the lazy dogthe quick brown fox jump over the lazy dogthe quick brown fox jump over the lazy dogthe quick brown fox jump over the lazy dogthe quick brown fox jump over the lazy dogthe quick brown fox jump over the lazy dogthe quick brown fox jump over the lazy dogthe quick brown fox jump over the lazy dogs
Number of Calculations: 1

Test 1
Total Time: 210
Result: True

Test 2
Total Time: 122
Result: True

Test 3
Total Time: 128
Result: True

--------  END COMPARISON TEST  --------

-------- BEGIN COMPARISON TEST --------
Input: the quick brown fox jumps over the lazy dog
Number of Calculations: 100

Test 1
Total Time: 2094
Result: True

Test 2
Total Time: 5872
Result: True

Test 3
Total Time: 4402
Result: True

--------  END COMPARISON TEST  --------

-------- BEGIN COMPARISON TEST --------
Input: the quick brown fox jump over the lazy dog
Number of Calculations: 100

Test 1
Total Time: 2049
Result: False

Test 2
Total Time: 4413
Result: False

Test 3
Total Time: 3174
Result: False

--------  END COMPARISON TEST  --------

-------- BEGIN COMPARISON TEST --------
Input: the quick brown fox jump over the lazy dogthe quick brown fox jump over the lazy dogthe quick brown fox jump over the lazy dogthe quick brown fox jump over the lazy dogthe quick brown fox jump over the lazy dogthe quick brown fox jump over the lazy dogthe quick brown fox jump over the lazy dogthe quick brown fox jump over the lazy dogthe quick brown fox jump over the lazy dogthe quick brown fox jump over the lazy dogthe quick brown fox jump over the lazy dogthe quick brown fox jump over the lazy dogthe quick brown fox jump over the lazy dogthe quick brown fox jump over the lazy dogthe quick brown fox jump over the lazy dogthe quick brown fox jump over the lazy dogthe quick brown fox jump over the lazy dogthe quick brown fox jump over the lazy dogthe quick brown fox jump over the lazy dogthe quick brown fox jump over the lazy dogthe quick brown fox jump over the lazy dogthe quick brown fox jump over the lazy dogthe quick brown fox jump over the lazy dogthe quick brown fox jump over the lazy dog
Number of Calculations: 100

Test 1
Total Time: 29175
Result: False

Test 2
Total Time: 11565
Result: False

Test 3
Total Time: 11205
Result: False

--------  END COMPARISON TEST  --------

-------- BEGIN COMPARISON TEST --------
Input: the quick brown fox jumps over the lazy dogthe quick brown fox jumps over the lazy dogthe quick brown fox jumps over the lazy dogthe quick brown fox jumps over the lazy dogthe quick brown fox jumps over the lazy dogthe quick brown fox jumps over the lazy dogthe quick brown fox jumps over the lazy dogthe quick brown fox jumps over the lazy dogthe quick brown fox jumps over the lazy dogthe quick brown fox jumps over the lazy dogthe quick brown fox jumps over the lazy dogthe quick brown fox jumps over the lazy dogthe quick brown fox jumps over the lazy dogthe quick brown fox jumps over the lazy dogthe quick brown fox jumps over the lazy dogthe quick brown fox jumps over the lazy dogthe quick brown fox jumps over the lazy dogthe quick brown fox jumps over the lazy dogthe quick brown fox jumps over the lazy dogthe quick brown fox jumps over the lazy dogthe quick brown fox jumps over the lazy dogthe quick brown fox jumps over the lazy dogthe quick brown fox jumps over the lazy dogthe quick brown fox jumps over the lazy dog
Number of Calculations: 100

Test 1
Total Time: 16906
Result: True

Test 2
Total Time: 5834
Result: True

Test 3
Total Time: 4405
Result: True

--------  END COMPARISON TEST  --------

-------- BEGIN COMPARISON TEST --------
Input: the quick brown fox jump over the lazy dogthe quick brown fox jump over the lazy dogthe quick brown fox jump over the lazy dogthe quick brown fox jump over the lazy dogthe quick brown fox jump over the lazy dogthe quick brown fox jump over the lazy dogthe quick brown fox jump over the lazy dogthe quick brown fox jump over the lazy dogthe quick brown fox jump over the lazy dogthe quick brown fox jump over the lazy dogthe quick brown fox jump over the lazy dogthe quick brown fox jump over the lazy dogthe quick brown fox jump over the lazy dogthe quick brown fox jump over the lazy dogthe quick brown fox jump over the lazy dogthe quick brown fox jump over the lazy dogthe quick brown fox jump over the lazy dogthe quick brown fox jump over the lazy dogthe quick brown fox jump over the lazy dogthe quick brown fox jump over the lazy dogthe quick brown fox jump over the lazy dogthe quick brown fox jump over the lazy dogthe quick brown fox jump over the lazy dogthe quick brown fox jump over the lazy dogs
Number of Calculations: 100

Test 1
Total Time: 16082
Result: True

Test 2
Total Time: 12280
Result: True

Test 3
Total Time: 12484
Result: True

--------  END COMPARISON TEST  --------

-------- BEGIN COMPARISON TEST --------
Input: the quick brown fox jumps over the lazy dog
Number of Calculations: 10000

Test 1
Total Time: 171903
Result: True

Test 2
Total Time: 474281
Result: True

Test 3
Total Time: 444790
Result: True

--------  END COMPARISON TEST  --------

-------- BEGIN COMPARISON TEST --------
Input: the quick brown fox jump over the lazy dog
Number of Calculations: 10000

Test 1
Total Time: 151557
Result: False

Test 2
Total Time: 439224
Result: False

Test 3
Total Time: 337344
Result: False

--------  END COMPARISON TEST  --------

-------- BEGIN COMPARISON TEST --------
Input: the quick brown fox jump over the lazy dogthe quick brown fox jump over the lazy dogthe quick brown fox jump over the lazy dogthe quick brown fox jump over the lazy dogthe quick brown fox jump over the lazy dogthe quick brown fox jump over the lazy dogthe quick brown fox jump over the lazy dogthe quick brown fox jump over the lazy dogthe quick brown fox jump over the lazy dogthe quick brown fox jump over the lazy dogthe quick brown fox jump over the lazy dogthe quick brown fox jump over the lazy dogthe quick brown fox jump over the lazy dogthe quick brown fox jump over the lazy dogthe quick brown fox jump over the lazy dogthe quick brown fox jump over the lazy dogthe quick brown fox jump over the lazy dogthe quick brown fox jump over the lazy dogthe quick brown fox jump over the lazy dogthe quick brown fox jump over the lazy dogthe quick brown fox jump over the lazy dogthe quick brown fox jump over the lazy dogthe quick brown fox jump over the lazy dogthe quick brown fox jump over the lazy dog
Number of Calculations: 10000

Test 1
Total Time: 1653974
Result: False

Test 2
Total Time: 1020244
Result: False

Test 3
Total Time: 1212746
Result: False

--------  END COMPARISON TEST  --------

-------- BEGIN COMPARISON TEST --------
Input: the quick brown fox jumps over the lazy dogthe quick brown fox jumps over the lazy dogthe quick brown fox jumps over the lazy dogthe quick brown fox jumps over the lazy dogthe quick brown fox jumps over the lazy dogthe quick brown fox jumps over the lazy dogthe quick brown fox jumps over the lazy dogthe quick brown fox jumps over the lazy dogthe quick brown fox jumps over the lazy dogthe quick brown fox jumps over the lazy dogthe quick brown fox jumps over the lazy dogthe quick brown fox jumps over the lazy dogthe quick brown fox jumps over the lazy dogthe quick brown fox jumps over the lazy dogthe quick brown fox jumps over the lazy dogthe quick brown fox jumps over the lazy dogthe quick brown fox jumps over the lazy dogthe quick brown fox jumps over the lazy dogthe quick brown fox jumps over the lazy dogthe quick brown fox jumps over the lazy dogthe quick brown fox jumps over the lazy dogthe quick brown fox jumps over the lazy dogthe quick brown fox jumps over the lazy dogthe quick brown fox jumps over the lazy dog
Number of Calculations: 10000

Test 1
Total Time: 1567746
Result: True

Test 2
Total Time: 497002
Result: True

Test 3
Total Time: 444799
Result: True

--------  END COMPARISON TEST  --------

-------- BEGIN COMPARISON TEST --------
Input: the quick brown fox jump over the lazy dogthe quick brown fox jump over the lazy dogthe quick brown fox jump over the lazy dogthe quick brown fox jump over the lazy dogthe quick brown fox jump over the lazy dogthe quick brown fox jump over the lazy dogthe quick brown fox jump over the lazy dogthe quick brown fox jump over the lazy dogthe quick brown fox jump over the lazy dogthe quick brown fox jump over the lazy dogthe quick brown fox jump over the lazy dogthe quick brown fox jump over the lazy dogthe quick brown fox jump over the lazy dogthe quick brown fox jump over the lazy dogthe quick brown fox jump over the lazy dogthe quick brown fox jump over the lazy dogthe quick brown fox jump over the lazy dogthe quick brown fox jump over the lazy dogthe quick brown fox jump over the lazy dogthe quick brown fox jump over the lazy dogthe quick brown fox jump over the lazy dogthe quick brown fox jump over the lazy dogthe quick brown fox jump over the lazy dogthe quick brown fox jump over the lazy dogs
Number of Calculations: 10000

Test 1
Total Time: 1651452
Result: True

Test 2
Total Time: 1315011
Result: True

Test 3
Total Time: 1357914
Result: True

--------  END COMPARISON TEST  --------
```