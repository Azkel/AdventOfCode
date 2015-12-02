result = [0,0]
File.open('input.txt', 'r').each_line do |line|
    values = line.split('x').map { |a| a.to_i}.sort
    result[1] += (values[0] + values[1]) * 2 + values[0] * values[1] * values[2] 
    values = [ values[0]*values[1], values[1]*values[2], values[2]*values[0]]
    result[0] += values.min + (values[0] + values[1] + values[2]) * 2
end
puts result.to_s
