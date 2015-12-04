#!/usr/bin/env ruby
input = File.read("input.txt")
santa_position  = [0,0]
robosanta_position = [0, 0]
result = { 0.to_s + '-' + 0.to_s => 1}
robosanta_move = false
input.split("").each do |f|
    current_move = (robosanta_move ? robosanta_position : santa_position)
    if f == '^'
      current_move[1] += 1  
    elsif f == '>'
      current_move[0] += 1
    elsif f == '<'
      current_move[0] -= 1
    elsif f == 'v'
      current_move[1] -= 1
    end
    key = current_move[0].to_s + '-' + current_move[1].to_s
    result[key] = result.has_key?(key) ? result[key]+1 : 1
    robosanta_move = !robosanta_move
end

puts result.select { |k,v| v > 0 }.count
