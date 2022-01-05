
// Make nested array plane

const plane = function(arr, res = []) {
  for (const i of arr) {
    // const value = arr[i];

    if (Array.isArray(i)) {
      res.push(...plane(i));
    } else {
      res.push(i);
    }
    const index = arr.indexOf(i);

    arr[index] = res[index - 1];
  }

  return res;
};

const result = plane([1, [[2]], [3, 4], [5], [6, [7, 8]]]);
console.log(result);
