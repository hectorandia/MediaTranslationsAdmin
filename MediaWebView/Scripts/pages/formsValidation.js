/*
 *  Document   : formsValidation.js
 *  Author     : pixelcave
 *  Description: Custom javascript code used in Forms Validation page
 */

var FormsValidation = function() {

    return {
        init: function() {
            /*
             *  Jquery Validation, Check out more examples and documentation at https://github.com/jzaefferer/jquery-validation
             */
            /*selectz-chosen validator*/
            //$("#chosen").chosen();
            //$.validator.setDefaults({ ignore: ":hidden:not(select)" })
            /* Initialize Form Validation */
            $('#form-validation').validate({
                ignore: ":hidden:not(select)",
                errorClass: 'help-block animation-slideDown', // You can change the animation class for a different entrance animation - check animations page
                errorElement: 'div',
                errorPlacement: function(error, e) {
                    e.parents('.form-group > div').append(error);
                },
                highlight: function (e) {
                    ignore: ":hidden:not(select)",
                    $(e).closest('.form-group').removeClass('has-success has-error').addClass('has-error');
                    $(e).closest('.help-block').remove();
                },
                success: function(e) {
                    // You can use the following if you would like to highlight with green color the input after successful validation!
                    ignore: ":hidden:not(select)",
                    e.closest('.form-group').removeClass('has-success has-error'); // e.closest('.form-group').removeClass('has-success has-error').addClass('has-success');
                    e.closest('.help-block').remove();
                },
                rules: {
                    Name: {
                        required: true
                    },
                    LastName: {
                        required: true
                    },
                    Email: {
                        required: true,
                        email: true
                    },
                    FirstLanguage: {
                        required: true,
                    },
                    Country: {
                        required: true,
                    },
                    val_skill: {
                        required: true
                    },
                    val_website: {
                        required: true,
                        url: true
                    },
                    val_digits: {
                        required: true,
                        digits: true
                    },
                    val_number: {
                        required: true,
                        number: true
                    },
                    val_range: {
                        required: true,
                        range: [1, 1000]
                    },
                    val_terms: {
                        required: true
                    }
                },
                messages: {
                    Name: {
                        required: 'Please enter a customer name'
                    },
                    LastName: 'Please enter a customer last name',
                    Email: {
                        required: 'Please enter a valide email'                      
                    },
                    //val_confirm_password: {
                    //    required: 'Please provide a password',
                    //    minlength: 'Your password must be at least 5 characters long',
                    //    equalTo: 'Please enter the same password as above'
                    //},
                    FirstLanguage: 'Please select a language!',
                    Country: 'Please select a country!',
                    val_website: 'Please enter your website!',
                    val_digits: 'Please enter only digits!',
                    val_number: 'Please enter a number!',
                    val_range: 'Please enter a number between 1 and 1000!',
                    val_terms: 'You must agree to the service terms!'
                }
            });

            // Initialize Masked Inputs
            // a - Represents an alpha character (A-Z,a-z)
            // 9 - Represents a numeric character (0-9)
            // * - Represents an alphanumeric character (A-Z,a-z,0-9)
            $('#masked_date').mask('99/99/9999');
            $('#masked_date2').mask('99-99-9999');
            $('#masked_phone').mask('(999) 999-9999');
            $('#masked_phone_ext').mask('(999) 999-9999? x99999');
            $('#masked_taxid').mask('99-9999999');
            $('#masked_ssn').mask('999-99-9999');
            $('#masked_pkey').mask('a*-999-a999');
        }
    };
}();