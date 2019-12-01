#!/usr/bin/env ruby
# Comment line 6 for part 1 or line 7 for part 2 solution.
reindeers = []
File.open('input.txt', 'r').each_line do |line|
  line = line.split(' ')
  reindeer = Hash['current', 0, 'resting', false, 'name', line[0], 'rest_time', line[13].to_i,
                  'speed', line[3].to_i, 'run_time', line[6].to_i, 'distance', 0, 'points', 0]
  reindeers.push(reindeer)
end
test = 0
for i in (0...2503)
  test += 1
  reindeers.each do |r|
    r['current'] +=1
    if r['resting'] and r['rest_time'] == r['current']
      r['resting'] = false
      r['current'] = 0
    elsif not r['resting']
      r['distance'] += r['speed']
      if r['current'] == r['run_time']
        r['current'] = 0
        r['resting'] = true
      end
    end
  end
  winning = reindeers.group_by{ |x| x['distance']}.max.last
  winning.each do |r|
    r['points'] += 1
  end
end
reindeers.each do |r|
  puts r['name'] + '- distance: ' + r['distance'].to_s + ', points: ' + r['points'].to_s
end