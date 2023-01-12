// Make nested array plane

const_plane = function(arr) {
  const res = [];
  for(let i = 0, length = arr.length; i < length; i++){
    value = arr[i];

    if (Array.isArray(value)) {
      res.push(...const_plane(value));
      } else {
      res.push(value);
    }
  }
  return res
}

require('../Tests/plane.js')(const_plane);
