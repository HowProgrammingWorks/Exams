// Make nested array plane

const plane = function (array) {
  const result = [];
  for (const item of array) {
    if (Array.isArray(item)) {
      result.push(...plane(item));
    } else {
      result.push(item);
    }
  }
  return result
}

const result = plane([1, [[2]], [3, 4], [5], [6, [7, 8]]]);
console.log(result);
