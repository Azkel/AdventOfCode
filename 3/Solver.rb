input = File.read("input.txt")

x = 0
x1 = 0
y = 0
y1 = 0
result = {}
result[x.to_s + '-' + y.to_s] = 1
roboSanta = false
input.split("").each do |f|
  if roboSanta
    if f == '^'
      y += 1  
    elsif f == '>'
      x += 1
    elsif f == '<'
      x -= 1
    elsif f == 'v'
      y -= 1
    end
    key = x.to_s + '-' + y.to_s
    if result.has_key?(key)
      result[key] +=1
    else
      result[key] = 1
    end
    roboSanta = false
  else
    if f == '^'
      y1 += 1  
    elsif f == '>'
      x1 += 1
    elsif f == '<'
      x1 -= 1
    elsif f == 'v'
      y1 -= 1
    end
    key = x1.to_s + '-' + y1.to_s
    if result.has_key?(key)
      result[key] +=1
    else
      result[key] = 1
    end
    roboSanta = true
  end
end

puts result.select { |k,v| v > 0 }.count
