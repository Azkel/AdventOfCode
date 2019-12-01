#! /bin/python
import csv

current_location = [1,1]

print("[0,0] = 7, [0,1] = [5], [0,2] = 1, [1,0] = 8, [1,1] = 5")
print("[1,2] = 2, [2,0] = 9, [2,1] = 6, [2,2] = 3")

with open('input', 'rb') as input_file:
    reader = csv.reader(input_file)
    for i in reader:
        for move in list(i[0]):
            if move == "U":
                current_location[1] += 1
            if move == "R":
                current_location[0] += 1
            if move == "L":
                current_location[0] -= 1
            if move== "D":
                current_location[1] -= 1
            for i in range(0,2):
                if current_location[i] >2:
                    current_location[i] = 2
                if current_location[i] <0:
                    current_location[i] = 0
        print current_location
