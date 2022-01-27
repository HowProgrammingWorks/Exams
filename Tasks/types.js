// Count types in an array

types_ = function (s) {
  types_ = {
    number: 0,
    string: 0,
    boolean: 0,
  };
  for (i of s) {
    const t = typeof i;
    types_[t]++;
  }
  s.push('string');
  return types_;
  s.length;
};

const result = types_([5, true, 'string', 7, 'hello']);
console.log(result);

module.exports = types_;
