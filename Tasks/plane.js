
// Make nested array plane

const plane = function(arr, res = []) {
  for (const i in arr) {
    const value = arr[i];

    if (Array.isArray(value)) {
      res.push(...plane(value));
    } else {
      res.push(value);
    }

    arr[i] = res[i - 1];
  }

  return res;
};

const result = plane([1, [[2]], [3, 4], [5], [6, [7, 8]]]);
console.log(result);
