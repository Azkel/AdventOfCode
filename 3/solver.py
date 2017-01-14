#! /bin/python

import csv
possible = 0
with open('input', 'rb') as input_file:
    reader = csv.reader(input_file)
    for line in reader:
        parsed_line = map(lambda x: int(x), filter(None, [i.strip() for i in line[0].split('  ')]))
        if parsed_line[0] + parsed_line[1] > parsed_line[2] and parsed_line[1] + parsed_line[2] > parsed_line[0] and parsed_line[0] + parsed_line[2] > parsed_line[1]:
            possible += 1
print(possible)
