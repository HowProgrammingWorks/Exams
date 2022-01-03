// Count types in array

const types_ = function(s) {
  for (const i of s) {
    const t = typeof i;
    types_[t]++;
  }
  s.push('string');
  return types_;
}

const result = types_([5, true, 'string', 7, 'hello']);
console.log(result);
