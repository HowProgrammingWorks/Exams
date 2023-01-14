'use strict'
const INTERSECTION =(object_1, object_2)=> {
  const arr_keys = Object.keys(object_1);
  for (const key of arr_keys) {
    object_1[key]===object_2[key]
    ?object_2[key]=object_1[key]
        :delete object_1[key]
  }
  return object_1;
};

require('../Tests/intersection.js')(INTERSECTION);

