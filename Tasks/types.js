// Count types in array

types_=function(s) {
  for (i of s)
  {
  const t = typeof i
  types_[t]++
  };
  s.push(
  'string'
  )
  return types_
}

const result = types_([5, true, 'string', 7, 'hello']);
console.log(result);
