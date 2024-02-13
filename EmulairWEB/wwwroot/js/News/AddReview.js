$(document).ready(function () {
    $('.btn-secondary').click(function () {
        debugger
        let reviewContainer = document.getElementById("review");
        let ratingContainer = document.getElementById("rating");
        let errorMessage = document.getElementById("errorMessageReview");
        let review = reviewContainer.value;
        let rating = ratingContainer.value;
        let id = reviewContainer.dataset.id;
        errorMessage.innerText = "";
        $.ajax({
            url: `/News/AddReview`,
            type: 'POST',
            data: {
                id: id,
                review: review,
                rating: rating
            },
            success: function (response) {
                if (response === true) {
                    toastr.success('Review was posted!', 'Success');
                    setTimeout(() => { window.location.href = `/News/Details/${id}`; }, "2000");
                }
                else {
                    toastr.error('Failed posting Review.', 'Error');
                }
            },
            error: function (error) {
                errorMessage.innerText = error.responseJSON[0].errorMessage;
            }
        });
    });
});
