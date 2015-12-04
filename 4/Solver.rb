#!/usr/bin/env ruby

input = ARGV[0]
require 'digest'
currentValue = 1
found = false
md5 = Digest::MD5.new
while not found
    currentValue += 1
    input+currentValue.to_s
    result = md5.hexdigest(input+currentValue.to_s)
    if result[0,6] == '000000' 
        puts result
        found = true
    end
   
end
puts currentValue

