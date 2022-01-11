// Generate int array from given range

_range = (...Range) => {
  let [from, to] = Range;
  if (to > from) {
    Range = new Array(to - from + 1);
    for (let i = from; i <= to; i++) {
      Range[i - from] = i;
    }
  } else {
    return [];
  }
  return Range;
};

const result = _range(10, 15);
console.log(result);
