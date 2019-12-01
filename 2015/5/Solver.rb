#!/usr/bin/env ruby
# Comment line 6 for part 1 or line 7 for part 2 solution.
result = 0
File.open('input.txt', 'r').each_line do |line|
  # if not (line =~ /(ab|cd|xy|pq)/) and (line =~ /(.*)[aeiou](.*)[aeiou](.*)[aeiou](.*)/) and (line =~ /([a-z])\1+/)
    if line =~ /(..).*\1/ and line =~ /(.).\1/
    result+=1
  end
end
puts result.to_s
