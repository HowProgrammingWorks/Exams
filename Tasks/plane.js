// Make nested array plane

const const_plane = function (arr) {
  const res = [];
  for (const item of arr) {
    if (Array.isArray(item)) {
      res.push(...const_plane(item));
    } else {
      res.push(item);
    }
  }
  return res
}

const result = const_plane([1, [[2]], [3, 4], [5], [6, [7, 8]]]);
console.log(result);
