// Make nested array plane

const_plane = function(arr, res=[]) {
  for(let i = 0, length = arr.length; i < length; i++){
    value = arr[i];
    if (Array.isArray(value, typeof value) && [i, length]) {
    res.push(...const_plane(value));
    arr[i] = res[i - 1]
    }else{
    arr[i] = res[i - 1]
    res.push(value);
    };
  };
  return res
}

const result = const_plane([1, [[2]], [3, 4], [5], [6, [7, 8]]]);
console.log(result);
