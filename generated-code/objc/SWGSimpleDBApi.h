#import <Foundation/Foundation.h>
#import "NIKApiInvoker.h"
#import "SWGRecords.h"
#import "SWGRecord.h"
#import "SWGTables.h"


@interface SWGSimpleDBApi: NSObject {

@private
    NSOperationQueue *_queue;
    NIKApiInvoker * _api;
}
@property(nonatomic, readonly) NSOperationQueue* queue;
@property(nonatomic, readonly) NIKApiInvoker* api;

-(void) addHeader:(NSString*)value forKey:(NSString*)key;

/**

 getTables() - List all tables.
 List the names of the available tables in this storage. By default, all tables are listed, use 'names' parameter to get specific tables. Use 'include_properties' to include any properties of the tables.
 @param include_properties Return all properties of the tables, if any.
 @param names Comma-delimited list of the table names to retrieve.
 */
-(void) getTablesWithCompletionBlock :(NSNumber*) include_properties 
        names:(NSString*) names 
        completionHandler: (void (^)(SWGTables* output, NSError* error))completionBlock;

/**

 createTables() - Create one or more tables.
 Post body should be a single table definition or an array of table definitions.
 @param body Array of tables to create.
 @param check_exist If true, the request fails when the table to create already exists.
 @param X-HTTP-METHOD Override request using POST to tunnel other http request, such as DELETE.
 */
-(void) createTablesWithCompletionBlock :(SWGTables*) body 
        check_exist:(NSNumber*) check_exist 
        X-HTTP-METHOD:(NSString*) X-HTTP-METHOD 
        completionHandler: (void (^)(SWGTables* output, NSError* error))completionBlock;

/**

 updateTableProperties() - Update properties of one or more tables.
 Post body should be a single table definition or an array of table definitions.
 @param body Array of tables with properties to update.
 */
-(void) updateTablePropertiesWithCompletionBlock :(SWGTables*) body 
        completionHandler: (void (^)(SWGTables* output, NSError* error))completionBlock;

/**

 deleteTables() - Delete one or more tables.
 Set the names of the tables to delete or set 'force' to true to clear the database.Alternatively, to delete by table definitions or a large list of names, use the POST request with X-HTTP-METHOD = DELETE header and post array of definitions or names.
 @param names Comma-delimited list of the table names to delete.
 @param force Set force to true to delete all tables in this database, otherwise 'names' parameter is required.
 */
-(void) deleteTablesWithCompletionBlock :(NSString*) names 
        force:(NSNumber*) force 
        completionHandler: (void (^)(SWGTables* output, NSError* error))completionBlock;

/**

 getRecords() - Retrieve one or more records.
 Use the 'ids' or 'filter' parameter to limit resources that are returned. Use the 'fields' parameter to limit properties returned for each resource. By default, all fields are returned for all resources. Alternatively, to send the 'ids' or 'filter' as posted data use the POST request with X-HTTP-METHOD = GET header and post array of ids or a filter.
 @param table_name Name of the table to perform operations on.
 @param ids Comma-delimited list of the identifiers of the resources to retrieve.
 @param filter SQL-like filter to limit the resources to retrieve.
 @param limit Set to limit the filter results.
 @param offset Set to offset the filter results to a particular record count.
 @param order SQL-like order containing field and direction for filter results.
 @param fields Comma-delimited list of field names to retrieve for each record.
 @param include_count Include the total number of filter results.
 @param id_field Comma-delimited list of the fields used as identifiers or primary keys for the table.
 */
-(void) getRecordsWithCompletionBlock :(NSString*) table_name 
        ids:(NSString*) ids 
        filter:(NSString*) filter 
        limit:(NSNumber*) limit 
        offset:(NSNumber*) offset 
        order:(NSString*) order 
        fields:(NSString*) fields 
        include_count:(NSNumber*) include_count 
        id_field:(NSString*) id_field 
        completionHandler: (void (^)(SWGRecords* output, NSError* error))completionBlock;

/**

 createRecords() - Create one or more records.
 Post data should be a single record or an array of records (shown). By default, only the id property of the record is returned on success. Use 'fields' parameter to return more info.
 @param table_name Name of the table to perform operations on.
 @param body Data containing name-value pairs of records to create.
 @param id_field Comma-delimited list of the fields used as identifiers or primary keys for the table.
 @param fields Comma-delimited list of field names to retrieve for each record.
 @param X-HTTP-METHOD Override request using POST to tunnel other http request, such as DELETE.
 */
-(void) createRecordsWithCompletionBlock :(NSString*) table_name 
        body:(SWGRecords*) body 
        id_field:(NSString*) id_field 
        fields:(NSString*) fields 
        X-HTTP-METHOD:(NSString*) X-HTTP-METHOD 
        completionHandler: (void (^)(SWGRecords* output, NSError* error))completionBlock;

/**

 replaceRecords() - Update (replace) one or more records.
 Post data should be a single record or an array of records (shown). By default, only the id property of the record is returned on success. Use 'fields' parameter to return more info.
 @param table_name Name of the table to perform operations on.
 @param body Data containing name-value pairs of records to update.
 @param ids Comma-delimited list of the identifiers of the resources to modify.
 @param filter SQL-like filter to limit the resources to modify.
 @param id_field Comma-delimited list of the fields used as identifiers or primary keys for the table.
 @param fields Comma-delimited list of field names to retrieve for each record.
 */
-(void) replaceRecordsWithCompletionBlock :(NSString*) table_name 
        body:(SWGRecords*) body 
        ids:(NSString*) ids 
        filter:(NSString*) filter 
        id_field:(NSString*) id_field 
        fields:(NSString*) fields 
        completionHandler: (void (^)(SWGRecords* output, NSError* error))completionBlock;

/**

 updateRecords() - Update (patch) one or more records.
 Post data should be a single record or an array of records (shown). By default, only the id property of the record is returned on success. Use 'fields' parameter to return more info.
 @param table_name Name of the table to perform operations on.
 @param body Data containing name-value pairs of records to update.
 @param ids Comma-delimited list of the identifiers of the resources to modify.
 @param filter SQL-like filter to limit the resources to modify.
 @param id_field Comma-delimited list of the fields used as identifiers or primary keys for the table.
 @param fields Comma-delimited list of field names to retrieve for each record.
 */
-(void) updateRecordsWithCompletionBlock :(NSString*) table_name 
        body:(SWGRecords*) body 
        ids:(NSString*) ids 
        filter:(NSString*) filter 
        id_field:(NSString*) id_field 
        fields:(NSString*) fields 
        completionHandler: (void (^)(SWGRecords* output, NSError* error))completionBlock;

/**

 deleteRecords() - Delete one or more records.
 Use 'ids' or filter to delete specific records, otherwise set 'force' to true to clear the table. By default, only the id property of the record is returned on success, use 'fields' to return more info. Alternatively, to delete by records, a complicated filter, or a large list of ids, use the POST request with X-HTTP-METHOD = DELETE header and post array of records, filter, or ids.
 @param table_name Name of the table to perform operations on.
 @param ids Comma-delimited list of the identifiers of the resources to delete.
 @param filter SQL-like filter to limit the resources to delete.
 @param force Set force to true to delete all records in this table, otherwise 'ids' parameter is required.
 @param id_field Comma-delimited list of the fields used as identifiers or primary keys for the table.
 @param fields Comma-delimited list of field names to retrieve for each record.
 */
-(void) deleteRecordsWithCompletionBlock :(NSString*) table_name 
        ids:(NSString*) ids 
        filter:(NSString*) filter 
        force:(NSNumber*) force 
        id_field:(NSString*) id_field 
        fields:(NSString*) fields 
        completionHandler: (void (^)(SWGRecords* output, NSError* error))completionBlock;

/**

 getRecord() - Retrieve one record by identifier.
 Use the 'fields' parameter to limit properties that are returned. By default, all fields are returned.
 @param table_name Name of the table to perform operations on.
 @param _id Identifier of the resource to retrieve.
 @param properties_only Return just the properties of the record.
 @param id_field Comma-delimited list of the fields used as identifiers or primary keys for the table.
 @param fields Comma-delimited list of field names to retrieve for each record.
 */
-(void) getRecordWithCompletionBlock :(NSString*) table_name 
        _id:(NSString*) _id 
        properties_only:(NSNumber*) properties_only 
        id_field:(NSString*) id_field 
        fields:(NSString*) fields 
        completionHandler: (void (^)(SWGRecord* output, NSError* error))completionBlock;

/**

 createRecord() - Create one record with given identifier.
 Post data should be an array of fields for a single record. Use the 'fields' parameter to return more properties. By default, the id is returned.
 @param table_name Name of the table to perform operations on.
 @param _id Identifier of the resource to create.
 @param id_field Comma-delimited list of the fields used as identifiers or primary keys for the table.
 @param body Data containing name-value pairs of the record to create.
 @param fields Comma-delimited list of field names to retrieve for each record.
 */
-(void) createRecordWithCompletionBlock :(NSString*) table_name 
        _id:(NSString*) _id 
        id_field:(NSString*) id_field 
        body:(SWGRecord*) body 
        fields:(NSString*) fields 
        completionHandler: (void (^)(SWGRecord* output, NSError* error))completionBlock;

/**

 replaceRecord() - Update (replace) one record by identifier.
 Post data should be an array of fields for a single record. Use the 'fields' parameter to return more properties. By default, the id is returned.
 @param table_name Name of the table to perform operations on.
 @param _id Identifier of the resource to update.
 @param id_field Comma-delimited list of the fields used as identifiers or primary keys for the table.
 @param body Data containing name-value pairs of the replacement record.
 @param fields Comma-delimited list of field names to retrieve for each record.
 */
-(void) replaceRecordWithCompletionBlock :(NSString*) table_name 
        _id:(NSString*) _id 
        id_field:(NSString*) id_field 
        body:(SWGRecord*) body 
        fields:(NSString*) fields 
        completionHandler: (void (^)(SWGRecord* output, NSError* error))completionBlock;

/**

 updateRecord() - Update (patch) one record by identifier.
 Post data should be an array of fields for a single record. Use the 'fields' parameter to return more properties. By default, the id is returned.
 @param table_name The name of the table you want to update.
 @param _id Identifier of the resource to update.
 @param id_field Comma-delimited list of the fields used as identifiers or primary keys for the table.
 @param body Data containing name-value pairs of the fields to update.
 @param fields Comma-delimited list of field names to retrieve for each record.
 */
-(void) updateRecordWithCompletionBlock :(NSString*) table_name 
        _id:(NSString*) _id 
        id_field:(NSString*) id_field 
        body:(SWGRecord*) body 
        fields:(NSString*) fields 
        completionHandler: (void (^)(SWGRecord* output, NSError* error))completionBlock;

/**

 deleteRecord() - Delete one record by identifier.
 Use the 'fields' parameter to return more deleted properties. By default, the id is returned.
 @param table_name Name of the table to perform operations on.
 @param _id Identifier of the resource to delete.
 @param id_field Comma-delimited list of the fields used as identifiers or primary keys for the table.
 @param fields Comma-delimited list of field names to retrieve for each record.
 */
-(void) deleteRecordWithCompletionBlock :(NSString*) table_name 
        _id:(NSString*) _id 
        id_field:(NSString*) id_field 
        fields:(NSString*) fields 
        completionHandler: (void (^)(SWGRecord* output, NSError* error))completionBlock;

@end
