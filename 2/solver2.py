#! /bin/python
import csv

current_location = [0,2]
not_allowed = [[0,0], [0,1], [0,3], [0,4], [1,0], [1,4], [3,0], [3,4],
        [4,0], [4,1], [4,3], [4,4]]
print("[0,2] = 5, [1,1] = A, [1,2] = 6, [1,3] = 2, [2,0] = D, [2,1] = B")
print("[2,2] = 7, [2,3] = 3, [2,4] = 1, [3,1] = C, [3,2] = 8, [3,3] = 4")
print("[4,2] = 9")

with open('input', 'rb') as input_file:
    reader = csv.reader(input_file)
    for i in reader:
        for move in list(i[0]):
            if move == "U":
                new_location = [current_location[0], current_location[1]+1]
            if move == "R":
                new_location = [current_location[0]+1, current_location[1]]
            if move == "L":
                new_location = [current_location[0]-1, current_location[1]]
            if move == "D":
                new_location = [current_location[0], current_location[1]-1]
            if not new_location in not_allowed and new_location.count(-1) == 0 and new_location.count(5) == 0:
                current_location = new_location
        print current_location
