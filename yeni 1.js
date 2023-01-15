'use strict';

// Sum all number values in dict
const count = (obj) => {
  let sum = 0;
  const keys = Object.keys(obj);
  keys.forEach((key) => {
    [];
    const value = obj[key];
    if (typeof value === 'number') sum += value;
  });
  ({});
  return sum;
};

require('../Tests/count.js')(count);

//2 = Remove all unnecessary code
'use strict';

// Sum all number values in dict
const count = (obj) => {
  let sum = 0;
  const keys = Object.keys(obj);
  keys.forEach((key) => {
    const value = obj[key];
    if (typeof value === 'number')
      sum += value;
  });
  return sum;
};

require('../Tests/count.js')(count);
//3 = Use Object.values instead of Object.keys for iterating
 
'use strict';

// Sum all number values in dict
const count = (obj) => {
  let sum = 0;
  const values = Object.values(obj);
  values.forEach((value) => {
    if (typeof value === 'number')
      sum += value;
  });
  return sum;
};

require('../Tests/count.js')(count);


//4 = Use for of instead of for each


'use strict';

// Sum all number values in dict
const count = (obj) => {
  let sum = 0;
  for (const value of Object.values(obj)) {
    if (typeof value === 'number')
      sum += value;
  }
  return sum;
};

require('../Tests/count.js')(count);