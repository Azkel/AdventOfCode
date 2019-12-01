#!/usr/bin/env ruby
# Comment line 6 for part 1 or line 7 for part 2 solution.
aunts = []



File.open('input.txt', 'r').each_line do |line|
  line = line.tr(':', '').tr(',', '').split(' ')
    aunt = Hash.new
    (0...line.length).step(2) do |n|
        aunt[line[n]] = line[n+1].to_i
    end
    aunts.push(aunt)
end
good_aunt = Hash['children', 3, 'cats', 7, 'samoyeds', 2, 'pomeranians', 3, 'akitas', 0, 'vizslas', 0,
              'goldfish', 5, 'trees', 3, 'cars', 2, 'perfumes', 1]
puts good_aunt
puts aunts[1].to_s
best_aunt = [0, nil]
aunts.each do |aunt|
  count = 0
  aunt.each do |k,v|
    if (['cats', 'trees'].include? k and good_aunt[k] < v) or
        (['pomeranians', 'goldfish'].include? k and good_aunt[k] > v)
      count += 1
    elsif not ['cats', 'trees', 'pomeranians', 'goldfish'].include? k and good_aunt[k] == v
      count += 1
    end
  end
  if count > best_aunt[0]
    best_aunt = [count, aunt]
  end
end
puts best_aunt.to_s

