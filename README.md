// Ở nơi cộng cộng
git config user.name "Nguyen Van A"
git config user.email "abc@example.com"

//Ở nhà nơi dùng riêng
git config --global user.name "Kstill6120"
git config --global user.email hpkstill@gmail.com

//tạo file init
git init 

//Liên kết repo
git remote add origin https://github.com/Kstill6120/Study.git

//Đóng gói dữ liệu để gửi lên repo
git add .

// Xác nhận đặt tên gói dữ liệu
git commit -m"sdsdsd"

//Đẩy lên repo
git push origin master
