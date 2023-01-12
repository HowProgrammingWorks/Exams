// Make nested array plane

const_plane = function(array) {
  const res = [];
  for(const element of array) {

    if (Array.isArray(value)) {
      res.push(...const_plane(value));
      } else {
      res.push(value);
    }
  }
  return res
}

require('../Tests/plane.js')(const_plane);
