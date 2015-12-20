import numpy

grid = numpy.zeros(shape=(1000, 1000))
with open('input.txt') as f:
    for line in f:
        line = line.split(' ')
        if line[0] == 'toggle':
            values1 = map(lambda x: int(x), line[1].split(','))
            values2 = map(lambda x: int(x), line[3].split(','))
            for x in range(values1[0], values2[0]+1):
                for y in range(values1[1], values2[1]+1):
                    grid[x, y] += 2  # Part 1: grid[x, y] = 1 if grid[x, y] == 0 else 0
        else:
            values1 = map(lambda x: int(x), line[2].split(','))
            values2 = map(lambda x: int(x), line[4].split(','))
            value = 1 if line[1] == 'on' else -1
            for x in range(values1[0], values2[0]+1):
                for y in range(values1[1], values2[1]+1):
                    grid[x, y] += value  # Part 1: grid[x, y] = value
                    grid[x, y] = 0 if grid[x, y] < 0 else grid[x, y]
print int(grid.sum())