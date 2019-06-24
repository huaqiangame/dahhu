







#import <Foundation/Foundation.h>
#import <CoreGraphics/CoreGraphics.h>
#import <CoreLocation/CoreLocation.h>

///该类为标注点的protocol，提供了标注类的基本信息函数
@protocol MAAnnotation <NSObject>

///标注view中心坐标
@property (nonatomic, readonly) CLLocationCoordinate2D coordinate;

@optional

///获取annotation标题
@property (nonatomic, readonly, copy) NSString *title;

///获取annotation副标题
@property (nonatomic, readonly, copy) NSString *subtitle;

/**
 * @brief 设置标注的坐标，在拖拽时会被调用
 * @param newCoordinate 新的坐标值
 */
- (void)setCoordinate:(CLLocationCoordinate2D)newCoordinate;

@end