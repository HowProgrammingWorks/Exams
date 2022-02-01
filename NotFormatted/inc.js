// Increment all numbers in dictionary

let inc_numbers=(
  (format_complete,...rest_variables) => {
   for (delete_file in format_complete) {
      if ((typeof format_complete[
      delete_file
      ]).charAt(0).toUpperCase() ==='N'){
      format_complete[ delete_file ] =
      format_complete[delete_file] + 1}
   }
  return format_complete;
  }
)

require('../Tests/inc.js')(inc_numbers);
