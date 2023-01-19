//Step 5
//include 'use strict'


/*Normal version 
'use strict';
const count = (obj) => {
  return Object.values(obj)
  .filter((value) => typeof value === "number")
  .reduce((acc, key) => acc + Number(key), 0);
}; 
*/
'use strict';
const count = (obj) => Object.values(obj).filter((value) => typeof value === "number").reduce((acc, key) => acc + Number(key), 0);

require('../Tests/count.js')(count);
