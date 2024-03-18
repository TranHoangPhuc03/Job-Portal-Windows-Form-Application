# Lập trình ứng dụng trên Windows - Đề tài: Tìm việc

## Chú ý

### Nhớ pull về cập nhật code trước khi bắt đầu làm
```
git pull
```
### Tách sang nhánh mới để làm việc trên máy của mình

Sau khi pull code mới nhất về, chạy lệnh các lệnh sau để tách nhánh trước khi làm
```
git checkout -b <tên nhánh>
    * <tên nhánh>: <tên>_<mô tả>
    * VD: Phuc_SQL, Anh_UI-Company, Loi_UI-User
```
Sau khi làm xong rồi thì push nhánh của mình lên. ***Không push hay chỉnh sửa gì trong nhánh master***
```
git push <tên nhánh>
```
Sau đó kiểm tra code ok, không conflicts gì hết mới merge vào master để giữ master luôn là code hoàn chỉnh.

***Tốt nhất là nên tách nhánh mỗi khi làm một chức năng mới. Để lỗi chỗ nào thì dễ backup.***