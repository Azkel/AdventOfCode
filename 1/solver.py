#! /bin/python
import csv
import collections
end_location = [0,0]
locations = []
current_turn = 0
first_double_visited = False
with open('input', 'rb') as input_file:
        reader = csv.reader(input_file, delimiter=',')
        for value in reader.next():
            directory = value.strip()[0]
            movement = int(value.strip()[1:])
            if directory == 'R':
                current_turn += 1
            else:
                current_turn -= 1
            if current_turn % 4 == 0:
                for i in range(0,movement):
                    locations.append((end_location[0], end_location[1]+i))
                end_location[1] += movement
            elif current_turn % 4 == 1:
                for i in range(0, movement):
                    locations.append((end_location[0]+i, end_location[1]))
                end_location[0] += movement
            elif current_turn % 4 == 2:
                for i in range(0, movement):
                    locations.append((end_location[0], end_location[1]-i))
                end_location[1] -= movement
            elif current_turn % 4 == 3:
                for i in range(0, movement):
                    locations.append((end_location[0]-i, end_location[1]))
                end_location[0] -= movement
            if not first_double_visited:
                max_occurence = collections.Counter(locations).most_common(1)[0]
                if max_occurence[1] == 2:
                    first_double_visited = True
                    print("Distance to first double visited: {}".format(sum([abs(i) for i in max_occurence[0]])))
# Print Manhattan distance
print("Final distance: {}".format(sum([abs(i) for i in end_location])))

