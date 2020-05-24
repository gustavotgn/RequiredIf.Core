# RequiredIf.Core

//Example
 public class Client
{      
        //Required if StatusId == 1
        [RequiredIf(nameof(StatusId ), 1, EOperator.EqualTo, ErrorMessage = "Name is required!")]
        public string Name { get; set; }

        public string StatusId { get; set; }
}
