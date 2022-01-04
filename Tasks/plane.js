// Make nested array plane

const plane = function(arr) {
  let res = [];
  for(let value of arr) {
    if (Array.isArray(value)) {
      res.push(...plane(value));
    } else {
      res.push(value);
    }
  }
  return res;
};

const result = plane([1, [[2]], [3, 4], [5], [6, [7, 8]]]);
console.log(result);
