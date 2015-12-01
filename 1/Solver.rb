test = File.read('input.txt')
result = 0
basement_floor = 0
was_in_basement = false
test.split("").each do |i|
  if i == '(' then result += 1
  else
    result -= 1
  end
  if not was_in_basement
    basement_floor += 1
    if result == -1
      was_in_basement = true
    end
  end 
end
puts 'Santa went to floor ' +result.to_s + ', first time he was in a basement: ' + basement_floor.to_s + '.'
