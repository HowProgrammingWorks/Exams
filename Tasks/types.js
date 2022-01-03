// Count types in array
'use strict'

const typeCounter=function(s) {
  types_=(
  {
  "number": 0,
  "string": 0,
  "boolean": 0,
  }
  )
  for (i of s)
  {
  const t = typeof i
  types_[t]++
  };
  s.push(
  'string'
  )
  return types_
  s.length;
}

const result = typeCounter([5, true, 'string', 7, 'hello']);
console.log(result);
