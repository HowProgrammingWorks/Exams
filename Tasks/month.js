// Get month number

const monthNames = ['jan','feb','mar','apr','may','jun','jul','aug','sep','oct','nov','dec',];
l = monthNames.length;

const Month = (s) => {

  for (let variable = 0; variable < l; variable++) {

    if (s.toLowerCase().startsWith(monthNames[variable])) 
    
    return variable + 1;
  }

  return -1;
};

require('../Tests/month.js')(Month);
