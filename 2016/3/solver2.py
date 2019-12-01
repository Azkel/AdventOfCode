#! /bin/python

import csv
possible = 0
number_of_rows = 0
rows = []
with open('input', 'rb') as input_file:
    reader = csv.reader(input_file)
    for line in reader:
        parsed_line = map(lambda x: int(x), filter(None, [i.strip() for i in line[0].split('  ')]))
        rows.append(parsed_line)
        number_of_rows += 1
        if number_of_rows % 3 == 0:
            for i in range(0,3):
                if rows[0][i] + rows[1][i] > rows[2][i] and rows[1][i] + rows[2][i] > rows[0][i] and rows[0][i] + rows[2][i] > rows[1][i]:
                    possible += 1
            rows = []
print(possible)
